
import React from 'react';
import { Modal, Button } from 'react-bootstrap'
const ErrorModal = props => {
    return (
        props.show && <Modal show={true} onHide={props.onHide}>
            <Modal.Header closeButton>
                <Modal.Title>Employees</Modal.Title>
            </Modal.Header>
            <Modal.Body>You enter an invalid employee Id.</Modal.Body>
            <Modal.Footer>
                <Button variant="secondary" onClick={props.onHide}>
                    Close
                </Button>

            </Modal.Footer>
        </Modal>
    );
};
export default ErrorModal;